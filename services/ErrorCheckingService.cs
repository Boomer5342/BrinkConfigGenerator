using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrinkConfigGenerator.services
{
    class ErrorCheckingService
    {
        public static bool RegAndVidErrorChecker(int[] comboIndex, bool enabled, String[,] textValidation, String[,] videoTextValidation, List<int> enabledVideos)
        {
            if (comboIndex[0] == -1)
            {
                MessageBox.Show("Please select station amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (enabled && comboIndex[1] == -1)
            {
                MessageBox.Show("Please select a video amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < textValidation.GetLength(0); i++)
            {
                if (textValidation[i, 0] == "")
                {
                    MessageBox.Show("Please fill in " + textValidation[i, 1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            foreach (int index in enabledVideos)
            {
                if (videoTextValidation[index, 0] == "")
                {
                    MessageBox.Show("Please fill in " + videoTextValidation[index, 1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public static bool SingleRegErrorChecker(String[,] textValidation, bool isStatOne)
        {
            for (int i = 0; i < textValidation.GetLength(0); i++)
            {
                if ((isStatOne && i == 1) || (isStatOne && i == 2))
                {
                    continue;
                }
                else
                {
                    if (textValidation[i, 0] == "")
                    {
                        MessageBox.Show("Please fill in " + textValidation[i, 1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool SingleVideoErrorChecker(String[,] textValidation)
        {
            for (int i = 0; i < textValidation.GetLength(0); i++)
            {
                if (textValidation[i, 0] == "")
                {
                    MessageBox.Show("Please fill in " + textValidation[i, 1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}