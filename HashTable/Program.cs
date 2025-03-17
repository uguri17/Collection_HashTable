using System;
using System.Collections; // non-generic-collection: 모든 데이터를 object로 저장 // ex) Hashtable, ArrayList 등

namespace Collection_HashTable
{
    class HashtableExample
    {
        static void Main(string[] args)
        {
            // Hashtable 생성 (key, value 저장)
            Hashtable phonebook = new Hashtable();

            // Hashtable에 key-value 추가
            phonebook.Add("Jo", "010-1");
            phonebook.Add("Yang", "010-2");
            phonebook.Add("Park", "010-3");

            foreach (DictionaryEntry pb in phonebook)
            {
                Console.WriteLine($"Add(): {pb}");                
            }

            // 특정 key에 해당하는 값을 가져와서 출력
            Console.WriteLine("\nJo의 전화번호: " + phonebook["Jo"]); // key를 호출하였더니 value가 출력되는 모습

            Console.WriteLine("");

            foreach (DictionaryEntry phbo in phonebook)
            {
                Console.WriteLine($"이름: {phbo.Key}, 전화번호: {phbo.Value}");
            }
        }
    }
}
