import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'

const TodoFilter = () => {
    const context = useContext(TodoContext)
    return (
        <>
            <div>
                <button className='btn btn-primary me-1' onClick={() => context.setFilterMode("all")}>All</button>
                <button className='btn btn-success me-1' onClick={() => context.setFilterMode(true)}>Complated</button>
                <button className='btn btn-warning' onClick={() => context.setFilterMode(false)}>Pending</button>
            </div>
        </>
    )
}

export default TodoFilter