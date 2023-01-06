using RecruitmentBOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

CandidateProfile c1 = new CandidateProfile{CId=201,FirstName="Pritam",LastName="Chavan",DOB=new DateTime(1997,11,2),Email="pritamchavan97@gmail.com",MobNo="465685323"};
        CandidateProfile c2 = new CandidateProfile{CId=202,FirstName="Hemant",LastName="Pangle",DOB=new DateTime(1998,04,05),Email="hemant.pangle@gmail.com",MobNo="232565323"};
        CandidateProfile c3 = new CandidateProfile{CId=203,FirstName="Jayesh",LastName="Gangurde",DOB=new DateTime(1997,07,14),Email="jayesh0576@gmail.com",MobNo="6395685323"};
        CandidateProfile c4 = new CandidateProfile{CId=204,FirstName="Sagar",LastName="Bhade",DOB=new DateTime(1996,01,08),Email="sagar.star02@gmail.com",MobNo="9795685323"};
        CandidateProfile c5 = new CandidateProfile{CId=205,FirstName="Tushar",LastName="Bhendarkar",DOB=new DateTime(1998,03,17),Email="tusharb1999@gmail.com",MobNo="785685323"};


List<CandidateProfile> profiles = new List<CandidateProfile>();

profiles.Add(c1);
profiles.Add(c2);
profiles.Add(c3);
profiles.Add(c4);
profiles.Add(c5);

bool flag =false;

string path=@"E:\Tushar Bhendarkar\Shinchan\Dotnet\Day5\JSONFile.json";

while(!flag)
{
    Console.WriteLine("1.Enter New Candidate 2.Display Candidate 3.Display Candiate from JSON 5.Exit ");
    
    int choice = Int32.Parse(Console.ReadLine());

    switch(choice)
    {
        case 1:
        {
        Console.WriteLine("Enter Candiate Id");
        int candidateId = Int32.Parse(Console.ReadLine());
        if (profiles.Exists(x=>x.CId==candidateId))
        {
                Console.WriteLine("Duplicate ID found. Plz enter valid ID");
        }
        else
        {
            Console.WriteLine("Enter Candiate First Name :");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Candiate Last Name :");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Candiate DOB");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Candiate Email id");
            string emilId = Console.ReadLine();
            Console.WriteLine("Enter Candiate Mobile No");
            string MobileNo = Console.ReadLine();

            profiles.Add (new CandidateProfile(candidateId,fname,lname,dob,emilId,MobileNo));
            Console.WriteLine("Candidate Added Successfully");

            var JSONfile = JsonSerializer.Serialize<List<CandidateProfile>>(profiles);

            
            File.WriteAllText(path,JSONfile);
            
        }

            break;
        }

        case 2:
        {
            foreach(CandidateProfile candList in profiles)
            {
                Console.WriteLine(candList.ToString());
            }

        break;
        }

        case 3:
        {
            string jsonstringfile = File.ReadAllText(path);
            var jsonReadFile = JsonSerializer.Deserialize<List<CandidateProfile>>(jsonstringfile);

            foreach(CandidateProfile listprofile in jsonReadFile)
            {
                Console.WriteLine(listprofile.ToString());
            }

            break;
        }
        case 5:
        flag = true;
        break;
    }

}
