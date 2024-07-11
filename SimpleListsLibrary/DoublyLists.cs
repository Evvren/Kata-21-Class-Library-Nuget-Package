namespace SimpleList{
        public class DoublyList{

                private DoublyNode? firstNode = null;
                private DoublyNode? lastNode = null;


                public void Add(string Input){

                        Information information = new Information(Input);
                        DoublyNode? node = new DoublyNode(information);

                        if (firstNode == null){ // No values in list

                            firstNode = node;
                            lastNode = node;


                        } else if (firstNode != null && lastNode != null){ // More than two values in list
                            
                            lastNode.setNextNode(node);
                            node.setPreviousNode(lastNode);
                            lastNode = node; 

                        } else {  // Only one value in list

                                lastNode = node;
                                firstNode.setNextNode(lastNode); 
                                lastNode.setPreviousNode(firstNode);

                        }

                }

                public bool Delete(string Input){
                        
                        DoublyNode? temporary = firstNode;

                        while (true){

                                if (firstNode.information.Value == Input){

                                        if (firstNode.nextNode == null){
                                                firstNode = null;
                                                lastNode = null;
                                                return true;
                                        }
                                        firstNode = firstNode.nextNode;
                                        firstNode.previousNode = null;
                                        return true;

                                } else if (temporary.nextNode.information.Value == Input){

                                        if(temporary.nextNode.nextNode == null){
                                                temporary.nextNode = null;
                                                return true;
                                        }
                                        temporary.nextNode.nextNode.previousNode = temporary;
                                        temporary.nextNode = temporary.nextNode.nextNode;
                                        return true;

                        
                                } else if (temporary == null){

                                        return false;

                                }
                                temporary = temporary.nextNode;
                        }

                }

                public string[] ReturnContent(){

                        int count = 0;
                        DoublyNode? current = firstNode;

                        while (current != null){

                               count++;
                               current = current.nextNode; 
                        }

                        string[] array = new string[count];
                        current = firstNode;

                        for(int i = 0; i < array.Length; i++){
                                array[i] = current.information.Value;
                                current = current.nextNode;
                        }
                        

                        return array;
                }

                public DoublyNode? Search(string? value){

                        DoublyNode? temporary = firstNode;
                        while (temporary.information.Value != value){

                                if (temporary == null){
                                        return null;
                                } else if (temporary.information.Value == value){
                                        return temporary;
                                }
                                temporary = temporary.nextNode;
                        }
                        return temporary;
                }

        }


}