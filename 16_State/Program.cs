using _16_State.Classes;

Context context = new();

AddedState added = new();
added.DoAction(context);

Console.WriteLine(context.GetState().ToString());

ModifiedState modified = new();
modified.DoAction(context);

Console.WriteLine(context.GetState().ToString());

DeletedState deleted = new();
deleted.DoAction(context);

Console.WriteLine(context.GetState().ToString());