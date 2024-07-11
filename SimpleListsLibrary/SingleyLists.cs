namespace SimpleList{

        public class SingleyList{

                private SingleyNode? firstNode = null;
                private SingleyNode? lastNode = null;


                public void Add(string Input){

                        Information information = new Information(Input);
                        SingleyNode? node = new SingleyNode(information);

                        if (firstNode == null){ // No values in list

                            firstNode = node;
                            lastNode = node;


                        } else if (firstNode != null && lastNode != null){ // More than two values in list

                            lastNode.setNextNode(node);
                            lastNode = node; 

                        } else {  // Only one value in list

                                lastNode = node;
                                firstNode.setNextNode(lastNode); 

                        }

                }

                public bool Delete(string Input){
                        
                        SingleyNode? temporary = firstNode;

                        while (true){

                                if (firstNode.information.Value == Input){
                                        firstNode = firstNode.nextNode;
                                        return true;
                                } else if (temporary.nextNode.information.Value == Input){
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
                        SingleyNode? current = firstNode;

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

                public SingleyNode? Search(string? value){

                        SingleyNode? temporary = firstNode;
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