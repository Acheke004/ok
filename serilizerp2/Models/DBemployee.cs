namespace Emp;
using System.IO;
using System.Text.Json;

public class DBemployee{

public static List<Employee> getlist(){

List<Employee> emplist=new List<Employee>();
//int empid, string ename, string dept, string email, string password

emplist.Add(new Employee(1,"a","b","c","d"));
emplist.Add(new Employee(2,"a","b","c","d"));
emplist.Add(new Employee(3,"a","b","c","d"));
emplist.Add(new Employee(4,"a","b","c","d"));
emplist.Add(new Employee(5,"a","b","c","d"));
 
 return emplist;
}

public static void seremployee(){
    List<Employee> emplist=getlist();
    string str=@"C:\cdac\prod.json";
    //    string jsonString=JsonSerializer.Serialize(allProducts);
    string jsonstring=JsonSerializer.Serialize(emplist);
    File.WriteAllText(str,jsonstring);
}
public static List<Employee> deemployee(){
   
    string str=@"C:\cdac\prod.json";
    string jsonstr1=File.ReadAllText(str);
    //    string jsonString=JsonSerializer.Serialize(allProducts);
     List<Employee>emplist=JsonSerializer.Deserialize<List<Employee>>(jsonstr1);
    return emplist;
}



}