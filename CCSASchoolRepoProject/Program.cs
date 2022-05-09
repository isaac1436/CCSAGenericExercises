public class DataStore<T> where T : IModelBase
{
    public void Create(T parameter)
    {
        Console.WriteLine("Created Successfully");
    }

    public List<string> Read(string file)
    {
        List<string> list = new List<string>();
        StreamReader sw = new StreamReader(file);

        using (sw)
        {
            string line = sw.ReadLine();
            int i = 0;
            while (line != null)
            {
                list.Add(line);

                line = sw.ReadLine();
                i++;
            }
        }

        return list;
    }

    public void ReadOne<U>(int ID, List<U> arr)
    {
        object one = ((object)arr[ID]).ToString();
        Console.WriteLine(one);
    }

    public void Update(T parameter)
    {
        Console.WriteLine("Updated Successfully");
    }

    public void Delete(T parameter)
    {
        Console.WriteLine("Deleted Successfully");
    }

}

public class Teacher : IModelBase
{
    public int EmployeeID { get; set; }
    public string name { get; set; }
    public string classID { get; set; }

    public double pay
    {
        get
        {
            return 45000 + (5000 * EmployeeID);
        }
    }
}

public class Student : IModelBase
{
    public int studentID { get; set; }
    public string name { get; set; }
    public string classID { get; set; }
}

public class Non_Academics : IModelBase
{
    public int workerID { get; set; }
    public string name { get; set; }
    public double pay
    {
        get
        {
            return 250000 / workerID;
        }
    }
}
public interface IModelBase { }