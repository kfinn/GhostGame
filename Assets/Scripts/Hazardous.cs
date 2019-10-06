using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazardous : MonoBehaviour
{
    private ContactPoint2D[] contactPoints;
    public Collider2D target;
    public GameObject collision;

    void Start() {
        contactPoints = new ContactPoint2D[1];
    }

    void Update() {
        var contactPointsCount = GetComponent<Collider2D>().GetContacts(contactPoints);
        if (contactPointsCount > 0) {
            var contactPoint = contactPoints[0];
            collision.transform.position = contactPoint.point;
            collision.SetActive(true);

            SceneManager.LoadScene("Death Scene", LoadSceneMode.Single);
        }
    }
}
