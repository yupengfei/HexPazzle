using UnityEngine;

[System.Serializable]
public struct HexCoordinates {
    [SerializeField]
    private int x, z;

    public int X {
        get {
            return x;
        }
        // private set;
    }

    public int Z {
        get {
            return z;
        }
        // private set;
    }

    public int Y {
        get {
            return -this.x - this.z;
        }
    }

    public HexCoordinates(int x, int z) {
        this.x = x;
        this.z = z;
    }

    public static HexCoordinates FromOffsetCoordinates(int x, int z) {
        return new HexCoordinates(x - z / 2, z);
    }

    public override string ToString() {
        return "(" + X.ToString() + ", " + Y.ToString() + ", " + Z.ToString() + ")";
    }

    public string ToStringOnSeparateLines() {
        return X.ToString() + "\n" + Y.ToString() + "\n" + Z.ToString();
    }
}