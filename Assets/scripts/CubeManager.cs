using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject[] units;

    private GameObject CreatePlane(Color color, Vector3 scale)
    {
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.tag = "UnitCube";
        plane.transform.localScale = scale;
        //plane.transform.localRotation = Quaternion.Euler(new Vector3(90, 180, 0));
        Renderer render = (Renderer)plane.GetComponent("Renderer");
        render.material.color = color;
        return plane;
    }

    private void arrangeCube()
    {
        GameObject obj = GameObject.Find("background");

        //set the background color
        Renderer render = (Renderer)obj.GetComponent("Renderer");
        render.material.color = Color.yellow;
  
        float width = obj.GetComponent<MeshFilter>().mesh.bounds.size.x;
        float height = obj.GetComponent<MeshFilter>().mesh.bounds.size.z;

        var stoneW = width / 20.0f;
        var stoneH = 3.0f / 5.0f;

        var scaleH = stoneW / width;
        var scaleV = stoneH / height;
        Vector3 scale = new Vector3(scaleH, 1, scaleV);

        var startX = -width / 2.0f + stoneW / 2;
        var startY = height / 2 - stoneH / 2;

        //var unit = CreatePlane(Color.red, scale);
        //Instantiate(unit, new Vector3(startX, startY, 0),
        //            Quaternion.Euler(new Vector3(90, 180, 0)));

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                GameObject unit = null;
                var positon = new Vector3(startX + i * stoneW, startY - j * stoneH, 0);

                int index = 20 * j + i;
                if (0 == index % 3)
                {
                    unit = CreatePlane(Color.red, scale);
                }
                else if (1 == index % 3)
                {
                    unit = CreatePlane(Color.blue, scale);
                }
                else
                {
                    unit = CreatePlane(Color.black, scale);
                }
                unit.transform.localRotation = Quaternion.Euler(new Vector3(90, 180, 0));
                unit.transform.position = positon;
            }
        }
    }

	// Use this for initialization
	void Start ()
    {
        arrangeCube();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
