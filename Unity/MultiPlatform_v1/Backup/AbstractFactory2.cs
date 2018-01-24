using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractFactory2 : MonoBehaviour {
    NPCFactory enemyFactory = NPCFactoryProducer.getFactory("EnemyFactory");
    NPCFactory friendlyFactory = NPCFactoryProducer.getFactory("FriendlyFactory");
    
    Enemy enemy1;
    Enemy enemy2;

    Friendly friendly1;
    Friendly friendly2;

    void Awake(){
        enemy1 = EnemyFactory.getEnemy(EnemyTypes.flying);
        enemy1 = EnemyFactory.getEnemy(EnemyTypes.walking);

        friendly1 = FriendlyFactory.getFriendly(FriendlyTypes.flying);
        friendly2 = FriendlyFactory.getFriendly(FriendlyTypes.walking);
    }

    // Use this for initialization
    void Start () {
        enemy1.Move();
        enemy2.Attack();

        friendly1.Move();
        friendly2.Attack();
    }
}

public abstract class Enemy {
    public int health;
    public int attPow;

    public abstract void Move();
    public abstract void Attack();
}

public abstract class Friendly {
    public int health;
    public int attPow;

    public abstract void Move();
    public abstract void Attack();
}

public class FlyingEnemy : Enemy {
    public FlyingEnemy() {
        health = 10;
        attPow = 1;
    }

    public override void Attack() {
        Debug.Log("Flying Enemy Attacked");
    }

    public override void Move() {
        Debug.Log("Flying Enemy Moved");
    }
}

public class WalkingEnemy : Enemy {
    public WalkingEnemy() {
            health = 5;
            attPow = 3;
     }

    public override void Attack() {
            Debug.Log("Walking Enemy Attacked");
     }

    public override void Move() {
            Debug.Log("Walking Enemy Moved");
    }
}

public class FlyingFriendly : Friendly {
    public FlyingFriendly() {
        health = 10;
        attPow = 1;
    }

    public override void Attack() {
        Debug.Log("Flying Friendly Attacked");
    }

    public override void Move() {
        Debug.Log("Flying Friendly Moved");
    }
}

public class WalkingFriendly : Friendly {
    public WalkingFriendly() {
            health = 5;
            attPow = 3;
     }

    public override void Attack() {
            Debug.Log("Walking Friendly Attacked");
     }

    public override void Move() {
            Debug.Log("Walking Friendly Moved");
    }
}

public abstract class NPCFactory {
    public abstract Enemy getEnemy(EnemyTypes type);
    public abstract Friendly GetFriendly(FriendlyTypes type);
}

public class EnemyFactory : NPCFactory {
    public override Enemy getEnemy(EnemyTypes type) {
        switch (type) {
            case EnemyTypes.flying:
                return new FlyingEnemy();
            case EnemyTypes.walking:
                return new WalkingEnemy();
            default:
                return null;
        }
    }

    public override Friendly getFriendly(FriendlyTypes type) {
        return null;
    }
}

public class FriendlyFactory : NPCFactory {
    public override Friendly getFriendly(FriendlyTypes type) {
        switch (type) {
            case FriendlyTypes.flying:
                return new FlyingFriendly();
            case FriendlyTypes.walking:
                return new WalkingFriendly();
            default:
                return null;
        }
    }

    public override Enemy getFriendly(EnemyTypes type) {
        return null;
    }
}



public class NPCFactoryProducer {
    public static NPCFactory getFactory(string choice) {
        switch(choice) {
            case ("EnemyFactory"):
                return new EnemyFactory();

            case ("FriendlyFactory"):
                return new FriendlyFactory();

            default:
                return null;
        }
    }
}

public enum EnemyTypes {
flying=0,
walking
};

public enum FriendlyTypes {
flying=0,
walking
};