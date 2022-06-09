

Random random = new();

Console.WriteLine("Enter the ammount of cities:");

int numOfCities = Convert.ToInt32(Console.ReadLine());

int maxCost = 10;

int[,] adjacencyMatrix = CreateAdjacencyMatrix(numOfCities, maxCost, random);


(float maxSuitability , int[] solution, int numberOfGenerations) = geneticAlgorithmTSP(adjacencyMatrix, 200,
                    (float)1 / (numOfCities * (maxCost/2-1)), (float)0.8, (float)0.1, random);

if (solution.Length != solution.Distinct().Count())
{
    Console.WriteLine("Contains duplicates");
}
else
{
    Console.WriteLine("the number of generations was :" + numberOfGenerations);
    Console.WriteLine("the solutions costs is :" + (1 / maxSuitability));
    Console.WriteLine("The solution is");
    foreach (var item in solution)
    {
        Console.WriteLine(item);
        Console.WriteLine((char)25);
    }
    Console.WriteLine(solution[0]);
}


static (float, int[], int) geneticAlgorithmTSP(int[,] adjacencyMatrix, int populationNumber, float suitabilityLimit,
                float replacementPercent, float mutationPercent, Random random)
{
    float[] suitability = new float[populationNumber];
    int numberOfGenerations=0;

    List<int[]> population = InitializePopulation(populationNumber, adjacencyMatrix.GetLength(0), random);

    //Calculating suitability for each chromosome
    for (
        int i = 0; i < population.Count; i++)
    {
        suitability[i] = Suitability(population[i], adjacencyMatrix);
    }

    //Main loop
    while(numberOfGenerations < 1000 )
    {
        //Checking if a satisfactory solution has been found
        if (suitability.Max() > suitabilityLimit)
        {
            break;
        }


        List<int[]> newPopulation = new();
        float sum = suitability.Sum();

        //Choosing the chromosomes that will not be replaced with roullete selection and placing them to the new population
        for (int l = 0; l < (1-replacementPercent)*population.Count; l++)
        {
            for (float i = 0, pick = random.NextSingle() * sum; (int)i < population.Count; i += 1, pick -= suitability[(int)i-1])
            {
                if (pick - suitability[(int)i] < 0)
                {
                    if (newPopulation.Contains(population[(int)i]))
                    {
                        continue;
                    }
                    else
                    {
                        newPopulation.Add(population[(int)i]);
                        break;
                    }
                }
            }
        }


        //Choosing the parents with roullete selection
        List<int[]> parents = new();
        for (int l = 0; l < replacementPercent * population.Count; l++)
        {
            for (float i = 0, pick = random.NextSingle() * sum; (int)i < population.Count; i += 1)
            {
                if (pick - suitability[(int)i] < 0)
                {
                        parents.Add(population[(int)i]);
                        break;
                }
                pick -= suitability[(int)i];
            }
        }

        //Single point crossover loop
        while (parents.Count>1)
        {
            //Choosing 2 random parents
            int n = random.Next(parents.Count);
            List<int> parent1 = parents[n].ToList();
            parents.RemoveAt(n);

            n = random.Next(parents.Count);
            List<int> parent2 = parents[n].ToList();
            parents.RemoveAt(n);

            int[] child1 = new int[parent1.Count];
            int[] child2 = new int[parent2.Count];
            

            //child1
            List<int> temp = parent1.GetRange(0, parent1.Count/2);
            List<int> temp1 = parent2.GetRange(0,parent2.Count);

            for (int i = 0; i < parent1.Count / 2; i++)
            {
                child1[i] = temp[i];
                temp1.Remove(temp[i]);
            }

            for (int i = parent1.Count/2; i < child1.Length; i++)
            {
                child1[i] = temp1.First();
                temp1.RemoveAt(0);
            }

            


            //child2
            temp = parent2.GetRange(0, parent2.Count/2);
            temp1 = parent1;

            for (int i = 0; i < parent2.Count / 2; i++)
            {
                child2[i] = temp[i];
                temp1.Remove(temp[i]);
            }

            for (int i = parent2.Count / 2; i < child2.Length; i++)
            {
                child2[i] = temp1.First();
                temp1.RemoveAt(0);
            }

            newPopulation.Add(child1);
            newPopulation.Add(child2);

        }

        //Mutation Loop
        for (int i = 0; i < (int)mutationPercent*newPopulation.Count; i++)
        {
            int n = random.Next(newPopulation.Count);
            int l = random.Next(newPopulation[n].Length);
            int j = random.Next(newPopulation[n].Length);

            int x = newPopulation[n][l];
            newPopulation[n][l] = newPopulation[n][j];
            newPopulation[n][j] = x;
        }

        population = newPopulation;

        for (int i = 0; i < population.Count; i++)
        {
            suitability[i] = Suitability(population[i], adjacencyMatrix);
        }

        for (int i = population.Count; i < suitability.Length; i++)
        {
            suitability[i] = 0;
        }


        numberOfGenerations++;
    }

    float maxSuitability = suitability.Max();
    
    int[] solution = population[suitability.ToList().IndexOf(maxSuitability)];

    return (maxSuitability, solution, numberOfGenerations);
}



static float Suitability(int[] chromosome, int[,] adjacencyMatrix)
{
    float sum = 0;
    for (int i = 0; i < chromosome.Length-1; i++)
    {
        sum += adjacencyMatrix[chromosome[i],chromosome[i+1]];
    }
    sum += adjacencyMatrix[chromosome[chromosome.Length-1],chromosome[0]];

    return 1 / sum;
}


static int[,] CreateAdjacencyMatrix(int numOfCities, int maxCost, Random random)
{
    //Initializing the symmetric adjacency matrix with costs up to 50
    int[,] adjacencyMatrix = new int[numOfCities, numOfCities];

    for (int i = 0; i < numOfCities; i++)
    {
        for (int j = i; j < numOfCities; j++)
        {
            if (i == j)
            {
                adjacencyMatrix[i, j] = 10000;
            }
            else
            {
                adjacencyMatrix[i, j] = random.Next(1, maxCost);
            }
        }
        for (int j = 0; j < i; j++)
        {
            adjacencyMatrix[i, j] = adjacencyMatrix[j, i];
        }
    }

    return adjacencyMatrix;
}


static List<int[]> InitializePopulation(int populationNumber, int numOfCities, Random random)
{
    List<int[]> population = new();

    for (int i = 0; i < populationNumber; i++)
    {
        List<int> randomList = new();
        int[] chromosome = new int[numOfCities];
        for (int j = 0; j < chromosome.Length; j++)
        {
            while (true)
            {
                int n = random.Next(numOfCities);
                if (!randomList.Contains(n))
                {
                    chromosome[j] = n;
                    randomList.Add(n);
                    break;
                }
            }
        }
        population.Add(chromosome);
    }

    return population;
}