using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculoVectores : MonoBehaviour
{
    [SerializeField] MyVector2D myFirstVector = new MyVector2D (12,12);
    [SerializeField] MyVector2D mySecondVector = new MyVector2D(2, 3);

    [SerializeField] MyVector2D newOrigin = new MyVector2D();
    MyVector2D zero = new MyVector2D(0,0);
    
    MyVector2D connector;
    MyVector2D connectorMarker; 
    [Range(0,1f)]
    [SerializeField] float connectorSize;
    [Range(0, 1f)]
    [SerializeField] float connectorMarkerSize; 

    

    void Start()
    {
        /*
        MyVector2D a = new MyVector2D(2, 3);
        MyVector2D b = new MyVector2D(4, 5);
        MyVector2D d = a.Sum(b);
        Debug.Log(d);
        */

        //vectorDependiente = myFirstVector.Res(mySecondVector);
    }

    private void Update()
    {
        myFirstVector.Draw(Color.red);
        mySecondVector.Draw(newOrigin, Color.blue);

        connector = (mySecondVector + newOrigin) - (zero + myFirstVector); 
        connector = connectorSize * connector;
        connector.Draw(myFirstVector,Color.cyan);

        connectorMarker = connector + myFirstVector;
        connectorMarker = connectorMarker * connectorMarkerSize;
        connectorMarker.Draw(Color.black);




        //ResultingVector = myFirstVector + mySecondVector;
        //ResultingVector.Draw(Color.yellow);
    }

    
    
}
