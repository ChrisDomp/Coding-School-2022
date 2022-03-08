using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; }
        public ActionResolver()
        {

        }
     
        public bool CheckIfDem(string s)
        {
            int result;
            if (!int.TryParse(s, out result))
            {
                Message message = new Message();
                message.Message_ = $"input{s} is not a demical number";
                message.TimeStamp = DateTime.Now;
                Logger.Write(message);
                return false;
            }
            return true;
        }
        public bool CheckIfString(string s)
        {
            
            if (!(s is string))
            {
                Message message = new Message();
                message.Message_ = $"input{s} is not a string";
                message.TimeStamp = DateTime.Now;
                Logger.Write(message);
                return false;
            }
            return true;
        }


        public void ModifyString(int s,ActionResponse response) {
            
             response.Output=Convert.ToString(s, 2);
             Message message = new Message();
             message.Message_ = "Input has been successfully converted to binary!";
             message.TimeStamp = DateTime.Now;
             Logger.Write(message);
        }
        public void ModifyString(string s, ActionResponse response)
        {
            string[] words = s.Split(' ');
            string longestWord = FindLongestWord(words); 
            response.Output =longestWord.ToUpper();
            Message message = new Message();
            message.Message_ = "Longest word of the input has been successfully Uppercased!";
            message.TimeStamp = DateTime.Now;
            Logger.Write(message);

        }
        public string FindLongestWord(string[] words)
        {
            string? longestWord = null;
            int longestWordLength = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (currentWord.Length > longestWordLength)
                {
                    longestWordLength = currentWord.Length;
                    longestWord = currentWord;
                }
            }
            
            return longestWord;
        }

        public void ReverseInput(string s, ActionResponse response)
        {
            response.Output= (string)s.Reverse();
            Message message = new Message();
            message.Message_ = "Input has been successfully reversed!";
            message.TimeStamp = DateTime.Now;
            Logger.Write(message);

        }

        public void Error()
        {
            Message message = new Message();
            message.Message_ = "An error has benn occured!";
            message.TimeStamp = DateTime.Now;
            Logger.Write(message);
        }
        public ActionResponse Execute(ActionRequest request)
        {

            var response = new ActionResponse() ;
            
            switch (request.Action)
            {
                case ActionEnum.Convert:
                    if (CheckIfDem(request.InputString))
                        ModifyString(Convert.ToInt32(request.InputString), response);
                    break;
                case ActionEnum.Uppercase:
                    if(CheckIfString(request.InputString))
                        ModifyString(request.InputString, response);
                    break;
                case ActionEnum.Reverse:
                    if (CheckIfString(request.InputString))
                        ReverseInput(request.InputString, response);
                    break;
                default:
                    Error();
                    break;
            }



            return response;
        }
    }
}
