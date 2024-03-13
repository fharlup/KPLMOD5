using System;

class Char
{
    public enum StateOrang
    {
        Jongkok,Berdiri,Tengkurap,Terbang
    };

    public enum Triger
    {
        TombolW,TombolS,TombolX
    }



    public class Transition
    {
        public StateOrang stateAwal;
        public StateOrang stateAkhir;
        public Triger triger;

        public Transition(StateOrang stateAwal, StateOrang stateAkhir, Triger triger)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.triger = triger;
        }
    }

    Transition[] transitions = {
        new Transition(StateOrang.Jongkok,StateOrang.Tengkurap,Triger.TombolS),
            new Transition(StateOrang.Tengkurap,StateOrang.Jongkok,Triger.TombolW),
             new Transition(StateOrang.Terbang,StateOrang.Jongkok,Triger.TombolX),
              new Transition(StateOrang.Terbang,StateOrang.Berdiri,Triger.TombolS),
               new Transition(StateOrang.Berdiri,StateOrang.Terbang,Triger.TombolW),
               new Transition(StateOrang.Berdiri,StateOrang.Jongkok,Triger.TombolS),
               new Transition(StateOrang.Jongkok,StateOrang.Berdiri,Triger.TombolW),
    };


    public StateOrang curentState = StateOrang.Berdiri;

    public StateOrang GetNextState(StateOrang stateAwal, Triger triger)
    {
        StateOrang stateAkhir = stateAwal;
        for (int i = 0; i < transitions.Length; i++)
        {
            Transition perubahan = transitions[i];
            if (stateAwal == perubahan.stateAwal && triger == perubahan.triger)
            {
                stateAkhir = perubahan.stateAkhir;
            }
        }
        return stateAkhir;
    }

    public void ActivateTriger(Triger triger)
    {
        curentState = GetNextState(curentState, triger);
        if (triger == Triger.TombolS)
        {
            Console.WriteLine("tombol arah bawah di tekan ");
        }else if (triger == Triger.TombolW)
        {
            Console.WriteLine("tombol arah atas di tekan ");
        }
        Console.WriteLine("orang nya sedamg " + curentState);
    }
}

class Program
{
    static void Main()
    {
        //Console.WriteLine(1302223032 % 3);
        Char orang1=new Char();
        Console.WriteLine("orang nya sedang " + orang1.curentState);
        orang1.ActivateTriger(Char.Triger.TombolS );
        orang1.ActivateTriger(Char.Triger.TombolS);
        orang1.ActivateTriger(Char.Triger.TombolW);
        orang1.ActivateTriger(Char.Triger.TombolW);
        orang1.ActivateTriger(Char.Triger.TombolW);
        orang1.ActivateTriger(Char.Triger.TombolX);
        orang1.ActivateTriger(Char.Triger.TombolW);
        orang1.ActivateTriger(Char.Triger.TombolW);
        orang1.ActivateTriger(Char.Triger.TombolS);


    }
}