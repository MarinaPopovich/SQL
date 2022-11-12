// using System.Data.SqlClient;
// string cons = @"Data Source= LAPTOP-IE81K5LH\SQLEXPRESS;
//Initial Catalog =University;
//Integrated Security = True";
//SqlConnection connection = new SqlConnection(cons);
//connection.Open();
//String commandText ="insert into [University].[dbo].[Group] values ('K31',3)";
//SqlCommand com= new SqlCommand(commandText, connection);
//com.ExecuteNonQuery();
using System.Data.SqlClient;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

string cons = @"Data Source= LAPTOP-IE81K5LH\SQLEXPRESS;
Initial Catalog =Family_tree;
Integrated Security = True";
SqlConnection connection = new SqlConnection(cons);
connection.Open();
Console.WriteLine(" Введите 'Закончить', чтобы закрыть Query. ");
string orde = Console.ReadLine();
while (orde != "Закончить")
{
    Console.WriteLine("Введите название таблицы: People, Places, Parents_children");
    String order1 = Console.ReadLine();
    if (order1 == "People")
    {
        string command = "select * from People";
        SqlCommand c = new SqlCommand
        (command, connection);
        SqlDataReader reader = c.ExecuteReader();
        //if (reader.HasRows)
        //{
        //   while (reader.Read())
        //   {
        //        string s1 = reader.GetValue(0).ToString();
        //        Console.WriteLine(s1);
        //    }
        //}
        //connection.Close();

        //connection.Open();

        Console.WriteLine("Введите: insert или read");
        String order = Console.ReadLine();
        if (order == "insert")
        {
            Console.WriteLine("Введите: Имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите: Фамилию");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите: Places_ID");
            string Places_ID = Console.ReadLine();
            string Commond = ($"insert into People values('" + Name + "','" + Surname + "','" + Places_ID + "')");
            SqlCommand com1 = new SqlCommand(Commond, connection);
            com1.ExecuteNonQuery();
        }

        else if (order == "read")
        {
            while (reader.Read())
            {
                string s1 = reader.GetValue(0).ToString();
                Console.WriteLine(s1);
            }
        }
       
    }
    else if (order1 == "Places")
    {
        string command = "select * from Places";
        SqlCommand co = new SqlCommand
        (command, connection);
        SqlDataReader reader = co.ExecuteReader();
        Console.WriteLine("Введите: insert или read");
        String order = Console.ReadLine();
        if (order == "insert")
        {
            Console.WriteLine("Введите: Город");
            string Name1 = Console.ReadLine();
            string command1 = ($"insert into People values('" + Name1 + "')");
            SqlCommand com2 = new SqlCommand(command1, connection);
            com2.ExecuteNonQuery();
        }
        else if (order == "read")
        {
            while (reader.Read())
            {
                string s1 = reader.GetValue(0).ToString();
                Console.WriteLine(s1);
            }
        }
        co.ExecuteNonQuery();
    }
    else if (order1 == "Parents_children")
    {
        string command = "select * from Parents_children";
        SqlCommand com = new SqlCommand
        (command, connection);
        SqlDataReader reader = com.ExecuteReader();
        Console.WriteLine("Введите: insert или read");
        String order = Console.ReadLine();
        if (order == "insert")
        {
            Console.WriteLine("Введите: ID_Parents1");
            string ID_Parents1 = Console.ReadLine();
            Console.WriteLine("Введите: ID_Parents2");
            string ID_Parents2 = Console.ReadLine();
            Console.WriteLine("Введите: ID_Children");
            string ID_Children = Console.ReadLine();
            string Commond = ($"insert into People values('" + ID_Parents1 + "','" + ID_Parents2 + "','" + ID_Children + "')");
            SqlCommand com3 = new SqlCommand(Commond, connection);
            com3.ExecuteNonQuery();
        }
        else if (order == "read")
        {
            while (reader.Read())
            {
                string s1 = reader.GetValue(0).ToString();
                Console.WriteLine(s1);
            }
        }
        com.ExecuteNonQuery();
    }
    Console.WriteLine(" Введите: 'Закончить', чтобы закрыть Query.");
    orde = Console.ReadLine();
    connection.Close();
}


