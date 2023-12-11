namespace SuperLandscapers_Blog.API.Model
{
    public interface OrderCreated
    {
        public string Username { get; set; }
        public string Email { get; set; } 
        public string ShortDescription { get; set; } 
    }
}
