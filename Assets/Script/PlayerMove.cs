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
        // 紒E獍醇丒淙丒⑸柚靡贫较丒
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // 按下任意移动紒E家贫?
        if (moveDirection.magnitude > 0)
        {
            MoveCharacter();
        }
        else
        {
            // 没有按下移动紒EＶ苟シ?
            animator.SetBool("walk", false);
        }
    }

    // 控制角色移动
    void MoveCharacter()
    {
        // 通过移动方向和速度来计算移动向量
        Vector3 movement = moveDirection * moveSpeed * Time.deltaTime;

        // 使用角色控制器移动角色
        controller.Move(movement);

        // 播放走路动画
        animator.SetBool("walk", true);

        // 使角色朝向移动方蟻E
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
