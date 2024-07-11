namespace SimpleList{

    public class SingleyNode{

        public Information? information {get;}
        public SingleyNode? nextNode {get; set;}

        public SingleyNode(Information? value){

            information = value;
            nextNode = null;
        }

        public void setNextNode(SingleyNode? value){

            nextNode = value;
        }

        public string? Value(){
            return information.Value;
            }
    }
    
    public class DoublyNode{

        public Information? information {get;}
        public DoublyNode? nextNode {get; set;}
        public DoublyNode? previousNode {get; set;}

        public DoublyNode(Information? value){

            information = value;
            nextNode = null;
            previousNode = null;
        }

        public void setNextNode(DoublyNode? value){

            nextNode = value;
        }

        public void setPreviousNode(DoublyNode? value){
            
            previousNode = value;
        }

        public string? Value(){
            return information.Value;
            }

    }

    

}

