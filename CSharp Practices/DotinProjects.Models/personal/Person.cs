namespace DotinProjects.Models.personal
{
    /// <summary>
    /// It's a class for people entity
    /// </summary>
    public class Person
    {
        #region [Fields]

        private string _firstname;
        private string _lastname;

        #endregion

        #region [Property]
        /// <summary>
        /// 
        /// </summary>
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Gender
        {
            get;
            set;
        }
        #endregion

        private float _grade;

        public float Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }


    }
}
