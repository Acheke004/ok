namespace Emp;

public class Employee{

public int empid{get; set;}
public string ename{get;set;}
public string dept{get;set;
}

public string email{get;set;}
public string password{get;set;}

public Employee()
{
    
}

    public Employee(int empid, string ename, string dept, string email, string password)
    {
        this.empid = empid;
        this.ename = ename;
        this.dept = dept;
        this.email = email;
        this.password = password;
    }

    
}