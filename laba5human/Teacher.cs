using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace laba5human
{
    class Teacher
    {
        string _name;
        string _academic_degree;
        string _academic_title;
        string _post;
        string _terms_of_attraction;
        string _list_of_subjects;
        string _education_level;
        string _qualification;
        string _name_of_direction;
        string _professional_development;
        string _work_experience;
        string _bio;
        string _publications;
        string _awards;


        Uri _url;
        Uri _imageUrl;

        public Teacher()
        {

        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string academic_degree
        {
            get { return _academic_degree; }
            set { _academic_degree = value; }
        }

        public string academic_title
        {
            get { return _academic_title; }
            set { _academic_title = value; }
            
        }

        public string post
        {
            get { return _post; }
            set { _post = value; }
        }

        public string terms_of_attraction
        {
            get { return _terms_of_attraction; }
            set { _terms_of_attraction = value; }
        }


        public string list_of_subjects
        {
            get { return _list_of_subjects; }
            set { _list_of_subjects = value; }
        }

        public string education_level
        {
            get { return _education_level; }
            set { _education_level = value; }
        }

        public string qualification
        {
            get { return _qualification; }
            set { _qualification = value; }
        }

        public string name_of_direction
        {
            get { return _name_of_direction; }
            set { _name_of_direction = value; }
        }

        public string professional_development
        {
            get { return _professional_development; }
            set { _professional_development = value; }
        }

        public string work_experience
        {
            get { return _work_experience; }
            set { _work_experience = value; }
        }

        public string bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        public string publications
        {
            get { return _publications; }
            set { _publications = value; }
        }

        public string awards
        {
            get { return _awards; }
            set { _awards = value; }
        }

        public Uri Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public Uri ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }


       
    }
}
