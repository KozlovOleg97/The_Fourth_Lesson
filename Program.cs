
int[] nums = { -15, -20, 1, 2, 3, 4, 5};

int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j <nums.Length; j++)
    {
        if (nums[i] == nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

Console.WriteLine("Output :");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}