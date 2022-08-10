using System;
using UnityEngine; 

[Serializable]

public struct MyVector2D
{
    public float x;
    public float y;

    public MyVector2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public static MyVector2D operator + (MyVector2D a, MyVector2D b)
    {
        return new MyVector2D(

        a.x + b.x,
        a.y + b.y

        );

    }
    public static MyVector2D operator -(MyVector2D a, MyVector2D b)
    {
        return new MyVector2D(
        a.x - b.x,
        a.y - b.y

        );
    }
    public static MyVector2D operator *(MyVector2D a, float b)
    {
        return new MyVector2D(

        a.x * b,
        a.y * b

        );
    }
    public static MyVector2D operator *(float b, MyVector2D a)
    {
        return new MyVector2D(

        a.x * b,
        a.y * b

        );
    }

    public void Draw(Color color)
    {
        Debug.DrawLine(Vector3.zero, new Vector3(x, y, 0), color);
       
    }

    public void Draw(MyVector2D origin, Color color) //sobrecarga para cambiar origen del vector
    {
        Debug.DrawLine(new Vector3(origin.x,origin.y), new Vector3(origin.x + x, origin.y + y), color);

    }
    
    public override string ToString()
    {
        return $"[{x},{y}]";
    }

}




