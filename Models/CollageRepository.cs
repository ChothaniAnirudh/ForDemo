namespace ForDemo.Models
{
    public static class CollageRepository
    {
        public static IEnumerable<StudentModel> Students { get; set; } = 
            new List<StudentModel>() {
            new StudentModel{ Id=1, Name="Ani", Email="chothani@gmail.com", Address="ok" },
            new StudentModel{ Id=2, Name="rj", Email="jn@gmail.com", Address="done"},
            new StudentModel{ Id=3, Name="rj", Email="jn@gmail.com", Address="done"}

            };
    }
}
