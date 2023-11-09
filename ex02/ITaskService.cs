namespace ex02
{
    public interface ITaskService
    {
        public List<Task1> getAllTask();

        public void addProduct(Task1 t);

        public void PutProductById(int id, string title, string description, DateTime date, preference p);

        public void DeleteTaskById(int id);

    }
}
