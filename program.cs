{\rtf1\ansi\ansicpg1251\cocoartf2576
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fmodern\fcharset0 Courier;\f1\fnil\fcharset0 Menlo-Regular;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab708
\pard\pardeftab708\ri-669\partightenfactor0

\f0\fs20 \cf0 using System;\
using System.Collections.Generic;\
namespace Simulator\
\{\
    abstract class Animal\
    \{\
        public string name;\
        public int age;\
        public int satiety;\
        public bool isHappy;\
        public abstract void move();\
        public abstract void eat();\
        public abstract void speak();\
        public void GetInfo()\
        \{\
            Console.WriteLine($"
\f1 \uc0\u1030 \u1084 
\f0 \'92
\f1 \uc0\u1103 
\f0 : \{name\}  
\f1 \uc0\u1042 \u1110 \u1082 
\f0 : \{age\} 
\f1 \uc0\u1057 \u1080 \u1090 \u1110 \u1089 \u1090 \u1100 
\f0 : \{satiety\} 
\f1 \uc0\u1056 \u1072 \u1076 \u1110 \u1089 \u1090 \u1100 
\f0 \{isHappy\}");\
        \}\
        public void hungry()\
        \{\
            this.satiety = this.satiety - 1;\
        \}\
    \}\
\
        class Cat : Animal\
\
        \{\
           public int walkingRate;\
           public Cat(string name)\
        \{\
           this.name = name;\
           this.age = 1;\
           this.satiety = 2;\
           this.walkingRate = 1;\
           isHappy = true;\
        \}\
\
        public int paws = 4;\
\
        public override void move()\
        \{\
            Console.WriteLine("
\f1 \uc0\u1058 \u1086 \u1087 
\f0 , 
\f1 \uc0\u1090 \u1086 \u1087 
\f0 , 
\f1 \uc0\u1090 \u1086 \u1087 
\f0 \'85");\
        \}\
        public override void speak()\
        \{\
            Console.WriteLine("
\f1 \uc0\u1052 \u1103 \u1091 
\f0 -
\f1 \uc0\u1084 \u1103 \u1103 \u1103 \u1091 
\f0 \'85");\
        \}\
\
        public override void eat()\
        \{\
            this.satiety = this.satiety + 1;\
        \}\
        public void Walk()\
        \{\
            move();\
            this.walkingRate = this.walkingRate + 1;\
        \}\
        \
\
\
        \}\
        class Parrot : Animal\
\
        \{\
            \
            \
        public int wings = 2;\
        public int paws = 2;\
 \
        public override void move()\
        \{\
            Console.WriteLine("*
\f1 \uc0\u1051 \u1077 \u1090 \u1080 \u1090 \u1100 
\f0 *");\
        \}\
        public override void speak()\
        \{\
            Console.WriteLine("
\f1 \uc0\u1055 \u1086 \u1087 \u1082 \u1072 
\f0 -
\f1 \uc0\u1044 \u1091 \u1088 \u1088 \u1088 \u1072 \u1082 
\f0 !");\
        \}\
\
        public override void eat()\
        \{\
            this.satiety = this.satiety - 1;\
        \}\
        public Parrot(string name)\
        \{\
            this.name = name;\
            this.age = 1;\
            this.satiety = 2;\
            isHappy = true;\
                \
        \}\
     \}\
\
        class Snake : Animal\
        \{\
            \
            public int limbs = 4;\
\
            public override void move()\
            \{\
                Console.WriteLine("*
\f1 \uc0\u1055 \u1086 \u1074 \u1079 \u1077 
\f0 *");\
            \}\
            public override void speak()\
            \{\
                Console.WriteLine("
\f1 \uc0\u1057 \u1089 \u1089 \u1089 \u1089 \u1089 \u1089 \u1089 \u1089 
\f0 \'85");\
            \}\
\
            public override void eat()\
            \{\
                this.satiety = this.satiety - 1;\
            \}\
            public Snake(string name)\
            \{\
                this.name = name;\
                this.age = 1;\
                this.satiety = 2;\
                isHappy = true;\
            \}\
        \}\
\
        class Owner\
        \{\
            public string name;\
            public Owner(string name)\
            \{\
                this.name = name;\
            \}\
\
            public void feeding(Animal animal)\
            \{\
                animal.eat();\
            \}\
            public void toWalk(Animal animal)\
            \{\
                animal.move();\
            \}\
\
\
        \}\
\
\
        class Program\
        \{\
            static void Main(string[] args)\
            \{\
\
\
                List<Animal> Animals = new List<Animal>();\
                Owner Ivan = new Owner("Ivan");\
                while (true)\
                \{\
                    Console.WriteLine("1-
\f1 \uc0\u1044 \u1110 \u1111 
\f0  
\f1 \uc0\u1079 
\f0  
\f1 \uc0\u1110 \u1089 \u1085 \u1091 \u1102 \u1095 \u1080 \u1084 \u1080 
\f0  
\f1 \uc0\u1090 \u1074 \u1072 \u1088 \u1080 \u1085 \u1072 \u1084 \u1080 
\f0  ");\
                    int x = Convert.ToInt32(Console.ReadLine());\
                    switch (x)\
                    \{\
                        case 1:\
                            Console.WriteLine("
\f1 \uc0\u1065 \u1086 
\f0  
\f1 \uc0\u1079 
\f0  
\f1 \uc0\u1085 \u1080 \u1084 
\f0  
\f1 \uc0\u1079 \u1088 \u1086 \u1073 \u1080 \u1090 \u1080 
\f0 ? 1-
\f1 \uc0\u1055 \u1086 \u1076 \u1080 \u1074 \u1080 \u1090 \u1080 \u1089 \u1103 
\f0  
\f1 \uc0\u1110 \u1085 \u1092 \u1086 \u1088 \u1084 \u1072 \u1094 \u1110 \u1102 
\f0  2-
\f1 \uc0\u1047 \u1084 \u1110 \u1085 \u1080 \u1090 \u1080 
\f0  
\f1 \uc0\u1110 \u1085 \u1092 \u1086 \u1088 \u1084 \u1072 \u1094 \u1110 \u1102 
\f0  3-
\f1 \uc0\u1055 \u1086 \u1075 \u1086 \u1076 \u1091 \u1074 \u1072 \u1090 \u1080 
\f0  4-
\f1 \uc0\u1055 \u1086 \u1075 \u1091 \u1083 \u1103 \u1090 \u1080 
\f0  
\f1 \uc0\u1079 
\f0  
\f1 \uc0\u1090 \u1074 \u1072 \u1088 \u1080 \u1085 \u1086 \u1102 
\f0 ");\
                            int zx = Convert.ToInt32(Console.ReadLine());\
                            Console.WriteLine("
\f1 \uc0\u1047 
\f0  
\f1 \uc0\u1103 \u1082 \u1086 \u1102 
\f0  
\f1 \uc0\u1090 \u1074 \u1072 \u1088 \u1080 \u1085 \u1086 \u1102 
\f0  
\f1 \uc0\u1074 \u1080 
\f0  
\f1 \uc0\u1093 \u1086 \u1095 \u1077 \u1090 \u1077 
\f0  
\f1 \uc0\u1079 \u1088 \u1086 \u1073 \u1080 \u1090 \u1080 
\f0  
\f1 \uc0\u1094 \u1102 
\f0  
\f1 \uc0\u1076 \u1110 \u1102 
\f0 ? (1,2,3,4...)\\n");\
                            int i = Convert.ToInt32(Console.ReadLine());\
                            switch (zx)\
                            \{\
                                case 1:\
                                    Animals[i - 1].GetInfo();\
                                    break;\
\
                                case 2:\
                                    Console.WriteLine("
\f1 \uc0\u1042 \u1074 \u1077 \u1076 \u1110 \u1090 \u1100 
\f0  
\f1 \uc0\u1085 \u1086 \u1074 \u1077 
\f0  
\f1 \uc0\u1110 \u1084 
\f0 \'92
\f1 \uc0\u1103 
\f0 :");\
                                    string newname = Console.ReadLine();\
                                    Animals[i - 1].name = newname;\
                                    Console.WriteLine($"
\f1 \uc0\u1030 \u1084 
\f0 \'92
\f1 \uc0\u1103 
\f0  
\f1 \uc0\u1079 \u1084 \u1110 \u1085 \u1077 \u1085 \u1086 
\f0  
\f1 \uc0\u1085 \u1072 
\f0 : \{Animals[i - 1]\}\\n");\
                                    break;\
                                case 3:\
                                    Ivan.feeding(Animals[i - 1]);\
                                    Console.WriteLine($"
\f1 \uc0\u1058 \u1074 \u1072 \u1088 \u1080 \u1085 \u1072 
\f0  \{Animals[i - 1].name\} 
\f1 \uc0\u1087 \u1086 \u1075 \u1086 \u1076 \u1086 \u1074 \u1072 \u1085 \u1072 
\f0 !\\n");\
                                    break;\
                                case 4:\
                                    \
                                    Ivan.toWalk(Animals[i - 1]);\
                                    Console.WriteLine($"
\f1 \uc0\u1042 \u1083 \u1072 \u1089 \u1085 \u1080 \u1082 
\f0  \{Ivan.name\} 
\f1 \uc0\u1087 \u1086 \u1075 \u1091 \u1083 \u1103 \u1074 
\f0  
\f1 \uc0\u1079 
\f0   \{Animals[i - 1].name\}!\\n");\
                                    break;\
                            \}\
                            break;\
\
                    \}\
\
                \}\
            \}\
        \
        \}\
    \}\
}