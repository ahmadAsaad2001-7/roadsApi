namespace TrickingLibarary.Api.Models;

public class Topic
{
    int id {get; set;}
    string title {get; set;}
    string description {get; set;}
    string url {get; set;}
    string image {get; set;}
    IFormFile  formfile {get; set;}
    
    
}