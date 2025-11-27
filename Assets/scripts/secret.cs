using UnityEngine;

public class LuzTrigger : MonoBehaviour
{
    [SerializeField] GameObject luz;

    private int contadorDentro = 0;

    private void Start()
    {
        luz.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            contadorDentro++;
            luz.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            contadorDentro--;

            if (contadorDentro <= 0)
            {
                luz.SetActive(false);
            }
        }
    }
}
