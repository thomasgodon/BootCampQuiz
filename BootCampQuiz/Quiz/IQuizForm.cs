using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svt.Caspar;

namespace BootCampQuiz.Quiz
{
    /// <summary>
    /// Quiz formulier interface
    /// </summary>
    public interface IQuizForm
    {
        QuizControl Control { get; set; }
        CasparDevice Caspar { get; set; }
    }
}
