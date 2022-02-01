namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        //Ordenar Array BulleSort
        public void OrdenarBulleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array [j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        //Array sem a separação de vírgula/linha
        // public void ImprimirArray(int[] array)
        // {
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         System.Console.WriteLine(array[i]);


         //Array Separado Por Linha!
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }
        
    }
}