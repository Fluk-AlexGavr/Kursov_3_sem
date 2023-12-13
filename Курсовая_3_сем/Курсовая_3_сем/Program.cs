namespace Курсовая_3_сем
{
    public class Program
    {

        public static void Main()
        {
            Account account = new();
            for(; ; )
            {
                string str;
                PrinterForUser.Print("Здравствуйте, выберите действие: \n1 - Авторизация \n2 - Регистрация \n3 - Просмотр очереди");
                str = SelectAction();
                if(str == "autorization")
                    DeleteAccount();
            }
        }

        private static string SelectAction()
        {
            Account account = new();
            
            string selectAction = EnterData.StringData();

            if (selectAction == "1")
            {
                AutorizationData();
                return "autorization";
            }
            else if (selectAction == "2")
            {
                Human newHum = RegistrationData();
                account.CreateNewAccount(newHum);
                return "registration";
            }
            else if (selectAction == "3")
            {
                ShowQueue(Queue.ReturnHumanList());
                return "showQueue";
            }
            else return "Nothing";
        }

        private static Human RegistrationData()
        {
            PrinterForUser.Print("Введите логин");
            string login = EnterData.StringData();
            PrinterForUser.Print("Введите пароль");
            string password = EnterData.StringData();
            PrinterForUser.Print("Введите время записи(yyyy MM dd HH mm ss)");
            string stringTime = EnterData.StringData();
            string rights = EnterData.StringData();

            if (rights == "admin")
                return new Admin(login, password, stringTime);
            else
                return new Visitor(login, password, stringTime);
        }

        private static void AutorizationData()
        {
            PrinterForUser.Print("Введите логин");
            string login = EnterData.StringData();
            PrinterForUser.Print("Введите пароль");
            string password = EnterData.StringData();

            Account account = new();
            Human autoriztionAccount = account.Autorization(Queue.ReturnHumanList(), new Visitor(login, password));
            
            if (autoriztionAccount is not null)
                PrinterForUser.Print($"{autoriztionAccount.Login}, вы записаны на {autoriztionAccount.StringTime}");
            else
                PrinterForUser.Print("Неправильные данные");
        }

        private static void ShowQueue(List<Human> list)
        {
            foreach(Human human in list)
            {
                PrinterForUser.Print($"{human.id}, {human.Login}, {human.StringTime}, {human.ReturnRights()}");
            }
        }

        private static void DeleteAccount()
        {
            Account account = new();
            PrinterForUser.Print("Хотите удалить аккаунт? Введите 0");
            string str = EnterData.StringData();
            if(str == "0")
            {
                PrinterForUser.Print("Введите логин");
                string login = EnterData.StringData();
                PrinterForUser.Print("Введите пароль");
                string password = EnterData.StringData();
                account.DeleteAccount(new Visitor(login, password));
            }
        }
    }
}