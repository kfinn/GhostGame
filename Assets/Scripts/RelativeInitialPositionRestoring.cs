using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RelativeInitialPositionRestoring : MonoBehaviour
{
  private const float AttachmentThreshold = 0.1f;

  public RelativeInitialPositionRestoring[] neighbors;

  [HideInInspector]
  public Vector3 initialPosition;
  private bool draggedLastFrame;
  private ISet<RelativeInitialPositionRestoring> attachedPieces;

  void Start()
  {
    initialPosition = transform.position;
    draggedLastFrame = false;
    attachedPieces = new HashSet<RelativeInitialPositionRestoring>() { this };
  }

  void Update()
  {
    var draggable = GetComponent<Draggable>();
    if (draggable.DroppedThisFrame())
    {
      var newAttachedPieces = new HashSet<RelativeInitialPositionRestoring>(attachedPieces);
      var unattachedNeighbors = attachedPieces.SelectMany(attachedPiece => attachedPiece.neighbors).Distinct().Except(attachedPieces);

      foreach (var unattachedNeighbor in unattachedNeighbors)
      {
        var initialOffset = InitialOffsetWith(unattachedNeighbor);
        var currentOffset = unattachedNeighbor.transform.position - transform.position;

        if (
            Mathf.Abs(initialOffset.x - currentOffset.x) < AttachmentThreshold &&
            Mathf.Abs(initialOffset.y - currentOffset.y) < AttachmentThreshold
        )
        {
          unattachedNeighbor.GetComponent<TargetSeeking>().targetPosition = GetComponent<TargetSeeking>().targetPosition + initialOffset;
          newAttachedPieces.UnionWith(unattachedNeighbor.attachedPieces);
        }
      }

      foreach (var newlyAttachedPiece in newAttachedPieces)
      {
        newlyAttachedPiece.attachedPieces = newAttachedPieces;
      }
    }
    else if (draggable.Dragged())
    {
      foreach (var attachedPiece in attachedPieces)
      {
        var targetPosition = GetComponent<TargetSeeking>().targetPosition;
        var initialOffset = InitialOffsetWith(attachedPiece);
        attachedPiece.GetComponent<TargetSeeking>().targetPosition = targetPosition + initialOffset;
      }
    }
  }

  private Vector3 InitialOffsetWith(RelativeInitialPositionRestoring other)
  {
    return other.initialPosition - initialPosition;
  }

  public int AttachedPiecesCount() {
    return attachedPieces.Count;
  }
}
