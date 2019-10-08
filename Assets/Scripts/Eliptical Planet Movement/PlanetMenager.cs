using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMenager : MonoBehaviour
{
    public int index = 0;

    public int getIndex = 0;

    List<Planets> planets = new List<Planets>();

    public GameObject planet;
    public GameObject comet;
    public GameObject astroied;
    public Transform star;



    float lastPlanetPoss;
  

    public void AddPlanet()
    {
        GameObject newobj = Instantiate(planet, transform.position, Quaternion.identity);


        planets.Add( new Planets(index, newobj, 8, 8, 3e-07f ,200, star, "Name"));

        OrbitalMovement orb = newobj.GetComponent<OrbitalMovement>();
        orb.index = index;
        orb.focus1 = star;

        orb.G = 2;//3e-07f;
        int m = 1;
        orb.M = m * Mathf.Pow(5, -index);
        getIndex = index;
        orb.a = 250 + (index*150);
        orb.b = 249 + (index*150);
        index++;

    }

    public void AddComet()
    {
        GameObject newobj = Instantiate(comet, transform.position, Quaternion.identity);


        planets.Add(new Planets(index, newobj, 8, 8, 3e-07f, 200, star, "Name"));

        OrbitalMovement orb = newobj.GetComponent<OrbitalMovement>();
        orb.index = index;
        orb.focus1 = star;

        orb.G = 2;//3e-07f;
        int m = 1;
        orb.M = 0.05f;
        getIndex = index;
        orb.a = 30 + (index * 100);
        orb.b = 30 + (index * 100);
        
    }

    public void AddAstroiedBelt()
    {
        GameObject newobj = Instantiate(astroied, transform.position, Quaternion.identity);

        //planets.Add(new Planets(index, newobj, 8, 8, 3e-07f, 200, star, "Name"));

        VisualizeOrbit orb = newobj.GetComponent<VisualizeOrbit>();
    
    
        getIndex = index;
        orb.a = 120;
        orb.b = 120;
        index++;
    }

    public void RemovePlanet()
    {
        foreach(Planets pl in planets)
        {
            if(pl.index == getIndex)
            {
                Destroy(pl.planet);
                index--;
                getIndex = index;
            }
        }
    }
}
