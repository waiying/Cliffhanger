using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Powerbar : MonoBehaviour
{

    public Image powerBar;
    public Text ratioText;
	static public float power;
    private float maxPower = 100;

    /*private void Start()
    {
		power = 100f;
		InvokeRepeating ("releasePower", 0f, 0.1f);
    }*/
	void Start() {
		InvokeRepeating ("addPower", 0, 1f);
	}

    void Update()
    {
		power = GettingHit.power;
		if (power <= 0) {
			power = 0;
		}
		//addPower ();
        float ratio = power / maxPower;
        powerBar.rectTransform.localScale = new Vector3(1, ratio, 1);
        ratioText.text = (ratio * 100).ToString("0");
    }

	void addPower() {
		if (power >= maxPower) {
			power = maxPower;
		} else {
			GettingHit.power += 5;
		}
	}

   /* private void addPower()
    {
        power += 1f;
        if(power >= maxPower)
        {
            power = maxPower;
        }
        UpdatePowerBar();
    }

    private void releasePower()
    {
        power -= 1f;
        if (power <= 0)
        {
            power = 0;
        }
        UpdatePowerBar();
    }*/
}