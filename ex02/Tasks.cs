namespace ex02
{
    public static class Tasks
    {
        public static List<Task1> tasks = new List<Task1>
        {
            new Task1("homework", "white", DateTime.Now, preference.a) ,
            new Task1("washDishes", "clean", DateTime.Now, preference.b),
            new Task1("bake a cake", "baking", DateTime.Now, preference.c),
            new Task1("cook a ckiken", "cooking", DateTime.Now, preference.d),
            new Task1("create a branch", "branch", DateTime.Now, preference.d)
        };
    }
}
