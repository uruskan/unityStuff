public class Enemy_Move : MonoBehaviour
{
    public GameObject enemy;
    public GameObject Sınır1;
    public GameObject Sınır2;
    public float enemy_hiz = 0.1f;
    bool goRight = true;
    void Start() {
        
       
    }
    void Update()
    {

        if (goRight)
        {

            enemy.transform.position = new Vector3(enemy.transform.position.x + enemy_hiz, transform.position.y);
        }
        else

        {
            enemy.transform.position = new Vector3(enemy.transform.position.x - enemy_hiz, transform.position.y);

        }

        float sınır1 = Sınır1.transform.position.x;
        float sınır2 = Sınır2.transform.position.x;
       

        if (enemy.transform.position.x < sınır1) {

            goRight = true;
        }
        if (enemy.transform.position.x > sınır2) {
            goRight = false;
            Debug.Log(enemy.transform.position.x - enemy_hiz);
        }
    }
}