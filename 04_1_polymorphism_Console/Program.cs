using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


/*
 * ポリモーフィズム（多態性）とは
 * 基底のクラスやインターフェースが同じ型であれば、継承や実装によって、複数の型を一つの型のように扱える振る舞いのこと。
 * １つのメソッドの呼び出しに対して、オブジェクト毎に異なる機能や動作を示すことを指す。
 * またサブクラスが増えても、利用する側の集計箇所の修正は不要になるのがメリット。
 * 
 * オブジェクト指向（抽象化、抽象クラス、インターフェース）は、大丈夫ですよね？
 */

var mammals = new List<MammalBase> { new Cat("たま"), new Dog("ポチ"), new Cat("みぃ"), new Dog("パトラッシュ") };

foreach (var mammal in mammals)
{
    //もし、サブクラスが増えても利用する側は、変更なし！
    mammal.MakeNames();
    mammal.MakeSounds();
}

/*
【実行結果】
たま: にゃおーん
ポチ: わあんうわぁん！！
みぃ: にゃおーん
パトラッシュ: わあんうわぁん！！
 */

/**
* <summary>
* 哺乳類の基底クラス
* </summary>
*/
public abstract class MammalBase
{
    public MammalBase (string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }
    public abstract void MakeSounds();
    public void MakeNames()  => Console.Write($"{Name}: ");
}

// 猫クラス
public class Cat : MammalBase
{
    public Cat(string name) : base(name) {}

    public override void MakeSounds() => Console.WriteLine("にゃおーん");
}

// 犬クラス
public class Dog : MammalBase
{
    public Dog(string name) : base(name) { }

    public override void MakeSounds() => Console.WriteLine("わあんうわぁん！！");
}