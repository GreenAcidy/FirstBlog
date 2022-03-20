using MyBlog.Domain.Repositories.Abstract;

namespace MyBlog.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository Items { get; set; }
        public DataManager (ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldsRepository;
            Items=serviceItemsRepository;
        }


    }
}
