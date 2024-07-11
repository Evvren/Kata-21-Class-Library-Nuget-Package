namespace SimpleList{

    public class SimpleListService{

            SingleyList? sList = new SingleyList();
             DoublyList? dList = new DoublyList();

        public void Add_S(string? input){
            sList.Add(input);
        }

        public void Delete_S(string? input){
            sList.Delete(input);   
        }

        public (SingleyNode? node, string error) Find_S(string? input){

                try{
                            return (sList.Search(input), string.Empty);
                } catch {
                            return (null, "Error, Did not find any items with that value.");
                }

        }

        public string[]? Display_S(){
            return sList.ReturnContent();
        }


        public void Add_D(string? input){
            dList.Add(input);
        }

        public void Delete_D(string? input){
            dList.Delete(input);   
        }

        public (DoublyNode? node, string error) Find_D(string? input){

                try{
                            return (dList.Search(input), string.Empty);
                } catch {
                            return (null, "Error, Did not find any items with that value.");
                }

        }

        public string[]? Display_D(){
            return dList.ReturnContent();
        }
    }
}