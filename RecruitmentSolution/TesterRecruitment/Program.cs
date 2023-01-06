using RecruitmentBOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
// using System.Text.Json.Serialization;


// int cid,string firstname,string lastname, Datetime dob, string email,
//     double mobno

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

foreach(CandidateProfile list in profiles)
{
    Console.WriteLine(list);
}

