namespace Lesson_18;

public interface IButtom
{
    void Render();
}

public interface ITextbox
{
    void Render();
}

public interface IUIFactory
{
    IButtom CreateButton();
    ITextbox CreateTextbox();
}

public class LightButton  : IButtom
{
    public void Render()
    {
        Console.WriteLine("render light button");
    }
}
public class DarkButton : IButtom
{
    public void Render()
    {
        Console.WriteLine("render dark button");
    }
}

public class DarkTextbox : ITextbox
{
    public void Render()
    {
        Console.WriteLine("render dark text box");
    }
}

public class LightTextbox : ITextbox
{
    public void Render()
    {
        Console.WriteLine("render light text box");
    }
}

public class DarkUIFactory : IUIFactory
{
    public IButtom CreateButton()
    {
        return new DarkButton();
    }

    public ITextbox CreateTextbox()
    {
        return new DarkTextbox();
    }
}

public class LightUIFactory : IUIFactory
{
    public IButtom CreateButton()
    {
        return new LightButton();
    }

    public ITextbox CreateTextbox()
    {
        return new LightTextbox();
    }
}


class Program
{
    static void Main()
    {
        // Можна змінити тему тут
        IUIFactory factory = new DarkUIFactory();
        // IUIFactory factory = new LightUIFactory();

        IButtom button = factory.CreateButton();
        ITextbox textBox = factory.CreateTextbox();

        button.Render();
        textBox.Render();
    }
}


