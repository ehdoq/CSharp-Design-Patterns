using _18_Mediator.Concrete;

Mediator md = new();

Teacher Aaa = new(md);
Aaa.Name = "Abc";

md.Teacher = Aaa;

Student Bbb = new(md);
Bbb.Name = "Bbb";

Student Ccc = new(md);
Ccc.Name = "Ccc";

md.Student = new List<Student> { Bbb, Ccc };

Aaa.SendNewImageUrl("slide.jpg");
Aaa.RecieveQuestion("is it true", Bbb);