using Photon.Pun;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public int point = 0;
    public UnityEngine.UI.Text pointText;
    public PhotonView photonView;
    private void Start()
    {
        photonView = GetComponent<PhotonView>();
    }
    private void Update()

    {
        if (pointText == null)
        {
            pointText = GameObject.Find("PointText").GetComponent<UnityEngine.UI.Text>();
        }
        if (pointText != null&&photonView.IsMine) pointText.text = "point: " + point.ToString();
        if (photonView.IsMine)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector2(-1, 0) * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector2(1, 0) * Time.deltaTime * speed);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        
            if (other.gameObject.tag == "point")
            {
                Destroy(other.gameObject);
                if(photonView.IsMine)point++;
                Debug.Log("point: " + point);
            }
        
    }
}
