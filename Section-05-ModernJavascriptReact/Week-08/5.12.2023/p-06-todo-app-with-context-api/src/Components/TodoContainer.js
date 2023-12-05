import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'
import Todo from './Todo'
import TodoEditForm from './TodoEditForm';
const TodoContainer = () => {
    const context = useContext(TodoContext)
    return (
        <>
            <ul className='list-group mt-2'>
                {

                    context.taskList.map(task => {
                        if (context.filterMode == "all") {
                            if (task.isEditing) {
                                return <TodoEditForm key={task.id} task={task} />
                            } else {
                                return <Todo task={task} key={task.id} />
                            }
                        } else if (task.isComplated == context.filterMode) {
                            if (task.isEditing) {
                                return <TodoEditForm key={task.id} task={task} />
                            } else {
                                return <Todo task={task} key={task.id} />
                            }
                        }
                    })
                }
            </ul>
        </>
    )
};

export default TodoContainer;