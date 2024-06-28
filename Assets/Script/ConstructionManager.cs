using UnityEngine;

public class ConstructionManager : MonoBehaviour
{
    public GameObject House; // 房屋Prefab
    private GameObject BuildingBase; // 建筑基础
    private bool isBuilding = false; // 是否正在建造

    void Update()
    {
        if (isBuilding)
        {
            // 发射一条射线从鼠标位置
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("Ground")))
            {
                // 如果射线击中了地面
                if (hit.collider != null)
                {
                    // 获取交点的位置
                    Vector3 buildPosition = hit.point;

                    // 如果建筑基础不存在，实例化一个
                    if (BuildingBase == null)
                    {
                        BuildingBase = Instantiate(House, buildPosition, Quaternion.identity);
                    }
                    else
                    {
                        // 如果建筑基础已存在，更新其位置
                        BuildingBase.transform.position = buildPosition;
                    }

                    // 如果鼠标左键按下，完成建造
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

    // 开始建造
    public void StartBuilding_House()
    {
        if (!isBuilding)
        {
            isBuilding = true;
        }
    }

    // 完成建造
    private void CompleteBuilding()
    {
        BuildingBase.GetComponentInChildren<BoxCollider>().enabled = true;
        BuildingBase.GetComponentInChildren<SphereCollider>().enabled = true;
        CreatManager.Wood -= 10;
        isBuilding = false;
        BuildingBase = null;
    }
}
