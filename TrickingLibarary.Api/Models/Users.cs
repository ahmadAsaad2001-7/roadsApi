namespace TrickingLibarary.Api.Models;

public class Users 
{
    int id {get; set;}
    string name {get; set;}
    string email {get; set;}
    string password {get; set;}
    string imgurl {get; set;}
    List<Comments> comments {get; set;}
    
    
}