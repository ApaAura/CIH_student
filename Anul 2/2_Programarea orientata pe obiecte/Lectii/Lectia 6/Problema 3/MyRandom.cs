internal class MyRandom : Random
{
    public MyRandom()
    {

    }
    public override int Next(int v)
    {
        string nr=v.ToString();
        return int.Parse(nr[base.Next(0,nr.Length-1)].ToString());
    }
}