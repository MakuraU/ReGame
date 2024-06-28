using UnityEngine;

public class ConstructionManager : MonoBehaviour
{
    public GameObject House; // ����Prefab
    private GameObject BuildingBase; // ��������
    private bool isBuilding = false; // �Ƿ����ڽ���

    void Update()
    {
        if (isBuilding)
        {
            // ����һ�����ߴ����λ��
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("Ground")))
            {
                // ������߻����˵���
                if (hit.collider != null)
                {
                    // ��ȡ�����λ��
                    Vector3 buildPosition = hit.point;

                    // ����������������ڣ�ʵ����һ��
                    if (BuildingBase == null)
                    {
                        BuildingBase = Instantiate(House, buildPosition, Quaternion.identity);
                    }
                    else
                    {
                        // ������������Ѵ��ڣ�������λ��
                        BuildingBase.transform.position = buildPosition;
                    }

                    // ������������£���ɽ���
                    if (Input.GetMouseButtonDown(0) && CreatManager.Wood >= 10)
                    {
                        CompleteBuilding();
                    }
                    if (Input.GetMouseButtonDown(1))
                    {
                        Destroy(BuildingBase);
                        isBuilding = false;
                        
                        BuildingBase = null;
                    }
                }
            }
        }
    }

    // ��ʼ����
    public void StartBuilding_House()
    {
        if (!isBuilding)
        {
            isBuilding = true;
        }
    }

    // ��ɽ���
    private void CompleteBuilding()
    {
        BuildingBase.GetComponentInChildren<BoxCollider>().enabled = true;
        BuildingBase.GetComponentInChildren<SphereCollider>().enabled = true;
        CreatManager.Wood -= 10;
        isBuilding = false;
        BuildingBase = null;
    }
}
