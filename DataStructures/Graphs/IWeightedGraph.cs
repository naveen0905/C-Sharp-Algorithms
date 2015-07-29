﻿using System;

namespace DataStructures.Graphs
{
    /// <summary>
    /// This interface should be implemented alongside the IGraph interface.
    /// </summary>
    public interface IWeightedGraph<T> where T : IComparable<T>
    {
        /// <summary>
        /// An enumerable collection of edges.
        /// </summary>
        System.Collections.Generic.IEnumerable<WeightedEdge<T>> Edges { get; }

        /// <summary>
        /// Connects two vertices together with a weight, in the direction: first->second.
        /// </summary>
        bool AddEdge(T source, T destination, int weight);

        /// <summary>
        /// Updates the edge weight from source to destination.
        /// </summary>
        bool UpdateEdgeWeight(T source, T destination, int weight);

        /// <summary>
        /// Get edge object from source to destination.
        /// </summary>
        WeightedEdge<T> GetEdge(T source, T destination);

        /// <summary>
        /// Returns the edge weight from source to destination.
        /// </summary>
        int GetEdgeWeight(T source, T destination);

        /// <summary>
        /// Get all outgoing weighted edges from vertex
        /// </summary>
        System.Collections.Generic.IEnumerable<WeightedEdge<T>> OutgoingEdges(T vertex);

        /// <summary>
        /// Returns the neighbours of a vertex as a dictionary of nodes-to-weights.
        /// </summary>
        System.Collections.Generic.Dictionary<T, int> NeighboursMap(T vertex);
    }
}

