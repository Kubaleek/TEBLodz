namespace Klasy._08._11._2024.Class
{
    public abstract class Shape
    {
       public abstract double GetArea();
       public abstract double GetPerymetr();
       public virtual string Draw(){
            return $""; 
       }
       public override string ToString()
       {
            return $"";
       }
       public virtual void Write()
       {

       }
    }
}
