using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ConsoleAppProject.App03

{
    public enum Grades
    {
        [Display(Name = "Fail")]
        [Description("Referred")]
        F,
        [Display(Name = "III")]
        [Description("BSc(Hons) Third Class")]
        D,
        [Display(Name = "II-2")]
        [Description("BSc(Hons) Lower Second")]
        C,
        [Display(Name = "II-1")]
        [Description("BSc(Hons) Upper Second")]
        B,
        [Display(Name = "1st")]
        [Description("BSc(Hons) First Class")]
        A
    }

    public enum Options
    {
        Enter,
        Marks,
        DisplayGrades,
        DisplayStats,
        DisplayGradeProfile,
        Exit
    }
}
