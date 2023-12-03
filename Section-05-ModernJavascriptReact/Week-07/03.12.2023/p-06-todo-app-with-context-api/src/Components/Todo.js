import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'

const Todo = ({ task }) => {
    const context = useContext(TodoContext)
    return (
        <>
            <li onClick={() => context.toggleComplete(task.id)} className={task.isComplated ? "list-group-item rounded-2 mb-2 text-decoration-line-through d-flex justify-content-between" : "list-group-item rounded-2 mb-2 d-flex justify-content-between"} >
                <div>{task.desc}</div>
                <div>
                    <button className='btn btn-warning btn-sm m-1'>E</button>
                    <button className='btn btn-danger btn-sm m-1' onClick={() => context.deleteTask(task.id)}>D</button>
                </div>
            </li>
        </>
    )
}

export default Todo