import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'
import Todo from './Todo'
const TodoContainer = () => {
    const context = useContext(TodoContext)
    return (
        <>
            <ul className='list-group mt-4'>
                {
                    context.taskList.map(task => <Todo task={task} key={task.id}/>)
                }
            </ul>
        </>
    )
};

export default TodoContainer;