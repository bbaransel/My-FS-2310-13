import React from 'react'
import SearchForm from '../../Components/SearchForm'
import Users from '../../Components/Users'

const SearchPage = () => {
    return (
        <>
            <SearchForm />
            {/* Bir de sonuçları göstermek için bir component tasarlayacağız. */}
            <Users />
        </>
    )
}

export default SearchPage