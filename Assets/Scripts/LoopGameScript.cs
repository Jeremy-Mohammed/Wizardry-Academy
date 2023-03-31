using UnityEngine;

public class LoopGameScript : MonoBehaviour
{
    [SerializeField] private Transform emptySpace = null;
    public Camera _camera;

    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit){

                if (Vector2.Distance(emptySpace.position, hit.transform.position) < 2.5){
                    Vector2 lastEmptySpacePos = emptySpace.position;
                    TilesScript thisTile = hit.transform.GetComponent<TilesScript>();
                    emptySpace.position = thisTile.targetPosition;
                    thisTile.targetPosition = lastEmptySpacePos;
                }
            }
        }
    }
}
