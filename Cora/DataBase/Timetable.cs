//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cora.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timetable
    {
        public int ID { get; set; }
        public Nullable<int> IdTeacher { get; set; }
        public Nullable<int> IdLesson { get; set; }
        public string Cabinet { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<int> IdGroup { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
