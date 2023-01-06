namespace RecruitmentBOL;


public class CandidateProfile
{
    public int CId{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public DateTime DOB{get;set;}
    public string Email{get;set;}
    public string MobNo{get;set;}

    public CandidateProfile()
    {
        this.CId=101;
        this.FirstName="Abhishek";
        this.LastName="Gade";
        this.DOB=new DateTime(2000,01,02);
        this.Email="abhi.gade2000@gmail.com";
        this.MobNo="13268565";
    }

    public CandidateProfile(int cid,string firstname,string lastname, DateTime dob, string email,
    string mobno)
    {
        this.CId = cid;
        this.FirstName = firstname;
        this.LastName = lastname;
        this.DOB = dob;
        this.Email = email;
        this.MobNo = mobno;

    }

    public override string ToString()
    {
        // return "Candidate id --->"+CId+" First Name --->"+FirstName+" Last Name --->"+LastName+" DOB --->"+DOB+
        // " Email id --->"+Email+" Mobile No --->"+MobNo;

        return string.Format("{0} , {1} , {2} , {3} , {4} , {5} ",CId,FirstName,LastName,DOB,Email,MobNo);
 
    }



}
