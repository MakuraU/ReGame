using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 3.0f; 
    private CharacterController controller; 
    private Vector3 moveDirection = Vector3.zero;
    public GameObject SwordOnPlayer;

    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>(); 
       
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        // ��Eⰴ��E�ȁE��������ƶ���ρE
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // ���������ƶ���E���ʼ�ƶ?
        if (moveDirection.magnitude > 0)
        {
            MoveCharacter();
        }
        else
        {
            // û�а����ƶ���E�ֹͣ�������?
            animator.SetBool("walk", false);
        }
    }

    // ���ƽ�ɫ�ƶ�
    void MoveCharacter()
    {
        // ͨ���ƶ�������ٶ��������ƶ�����
        Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;

        // ʹ�ý�ɫ�������ƶ���ɫ
        controller.Move(movement);

        // ������·����
        animator.SetBool("walk", true);

        // ʹ��ɫ�����ƶ���ρE
        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword")
        {
            SwordOnPlayer.SetActive(true);
            Destroy(other.gameObject, 0.1f);
        }
    }
}
