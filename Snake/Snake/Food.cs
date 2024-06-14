namespace Snake
{
    internal class Food
    {
        public int FoodPosX { get; private set; }
        public int FoodPosY { get; private set; }
        public bool IsEaten { get; private set; }
        public string FoodIcon { get; private set; }
        Random random = new Random();

        public Food()
        {
            IsEaten = false;
            SetFoodPos();
            SetRandomFood();
        }

        private readonly string[] _foodEmojis = new string[]
        {
            "\U0001F34E", // Red Apple 🍎
            "\U0001F34F", // Green Apple 🍏
            "\U0001F350", // Pear 🍐
            "\U0001F351", // Peach 🍑
            "\U0001F352", // Cherries 🍒
            "\U0001F353", // Strawberry 🍓
            "\U0001F354", // Hamburger 🍔
            "\U0001F355", // Pizza 🍕
            "\U0001F356", // Meat on Bone 🍖
            "\U0001F357", // Poultry Leg 🍗
            "\U0001F358", // Rice Cracker 🍘
            "\U0001F359", // Rice Ball 🍙
            "\U0001F35A", // Cooked Rice 🍚
            "\U0001F35B", // Curry Rice 🍛
            "\U0001F35C", // Steaming Bowl 🍜
            "\U0001F35D", // Spaghetti 🍝
            "\U0001F35E", // Bread 🍞
            "\U0001F35F", // French Fries 🍟
            "\U0001F360", // Roasted Sweet Potato 🍠
            "\U0001F361", // Dango 🍡
            "\U0001F362", // Oden 🍢
            "\U0001F363", // Sushi 🍣
            "\U0001F364", // Fried Shrimp 🍤
            "\U0001F365", // Fish Cake with Swirl 🍥
            "\U0001F366", // Soft Ice Cream 🍦
            "\U0001F367", // Shaved Ice 🍧
            "\U0001F368", // Ice Cream 🍨
            "\U0001F369", // Doughnut 🍩
            "\U0001F36A", // Cookie 🍪
            "\U0001F36B", // Chocolate Bar 🍫
            "\U0001F36C", // Candy 🍬
            "\U0001F36D", // Lollipop 🍭
            "\U0001F36E", // Custard 🍮
            "\U0001F36F", // Honey Pot 🍯
            "\U0001F37F", // Popcorn 🍿
            "\U0001F95E", // Pancakes 🥞
            "\U0001F950", // Croissant 🥐
            "\U0001F951", // Avocado 🥑
            "\U0001F952", // Cucumber 🥒
            "\U0001F953", // Bacon 🥓
            "\U0001F954", // Potato 🥔
            "\U0001F955", // Carrot 🥕
            "\U0001F956", // Baguette Bread 🥖
            "\U0001F957", // Green Salad 🥗
            "\U0001F958", // Shallow Pan of Food 🥘
            "\U0001F959", // Stuffed Flatbread 🥙
            "\U0001F95A", // Egg 🥚
            "\U0001F95B", // Glass of Milk 🥛
            "\U0001F95C", // Kiwi Fruit 🥝
            "\U0001F95D", // Kiwifruit 🥝
            "\U0001F960", // Sandwich 🥪
            "\U0001F961", // Bowl with Spoon 🥣
            "\U0001F962", // Coconut 🥥
            "\U0001F963", // Bowl with Chopsticks 🥢
            "\U0001F964", // Cup with Straw 🥤
            "\U0001F965", // Cupcake 🧁
            "\U0001F966", // Broccoli 🥦
            "\U0001F967", // Pie 🥧
            "\U0001F968", // Pretzel 🥨
            "\U0001F969", // Cut of Meat 🥩
            "\U0001F96A", // Sandwich 🥪
            "\U0001F96B", // Canned Food 🥫
            "\U0001F96C", // Leafy Green 🥬
            "\U0001F96D", // Mango 🥭
            "\U0001F96E", // Moon Cake 🥮
            "\U0001F96F", // Bagel 🥯
            "\U0001F9C0", // Cheese Wedge 🧀
            "\U0001F9C1", // Cupcake 🧁
            "\U0001F9C2", // Salt Shaker 🧂
        };
        public void SetFoodPos()
        {
            FoodPosX = random.Next(3, Console.WindowWidth-3);
            FoodPosY = random.Next(3, Console.WindowHeight-3);
        }

        public void SetRandomFood()
        {
            int randomIndex = random.Next(0, _foodEmojis.Length);
            FoodIcon = _foodEmojis[randomIndex];
        }

        public (int X, int Y) GetFoodPos()
        {
            return (FoodPosX, FoodPosY);
        }

        public string GetFoodIcon()
        {
            return FoodIcon;
        }

        public void GetsEaten()
        {
            IsEaten = true;
        }
    }
}
